using Bowling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Frame
    {
        private int score;
        private List<Roll> rolls;
        private bool lastFrame;
        private IGenerator _generator;

        public List<Roll> Rolls { get => rolls; set => rolls = value; }
        public bool LastFrame { get => lastFrame; set => lastFrame = value; }
        public int Score
        {
            get
            {
                int total = 0;
                Rolls.ForEach(r => total += r.Pins);
                return total;
            }
        }

        public Frame(IGenerator generator, bool lastFrame)
        {
            _generator = generator;
            LastFrame = lastFrame;
            score = 0;
            Rolls = new List<Roll>();
        }

        private void MakeRoll(int max)
        {
            throw new NotImplementedException();
        }

        public bool Roll()
        {
            if(!lastFrame)
            {
                if(Rolls.Count == 0 || (Rolls.Count < 2 && Rolls[0].Pins < 10))
                {
                    int max = Rolls.Count == 0 ? 10 : 10 - Rolls[0].Pins;
                    int pins = _generator.RandomPins(max);
                    Roll roll = new Roll(pins);
                    Rolls.Add(roll);
                    return true;
                }
                return false;
            }
            else
            {
                if(Rolls.Count == 1 && Rolls[0].Pins == 10)
                {
                    int pins = _generator.RandomPins(10);
                    Roll r = new Roll(pins);
                    Rolls.Add(r);
                    return true;
                }
                else if(Rolls.Count == 2 && Rolls[0].Pins == 10)
                {
                    int pins = _generator.RandomPins(10 - Rolls[1].Pins);
                    Roll r = new Roll(pins);
                    Rolls.Add(r);
                    return true;
                }
                else if(Rolls.Count == 2 && Rolls[0].Pins + Rolls[1].Pins == 10)
                {
                    int pins = _generator.RandomPins(10);
                    Roll r = new Roll(pins);
                    Rolls.Add(r);
                    return true;
                }
                return false;
            }
        }
    }
}
