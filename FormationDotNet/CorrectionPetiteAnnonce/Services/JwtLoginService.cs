using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CorrectionPetiteAnnonce.Services
{
    public class JwtLoginService : ILogin
    {

        private BaseRepository<Utilisateur> _utilisateurRepository;
        public JwtLoginService(BaseRepository<Utilisateur> utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }
        public bool IsLogged()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string Login(UserDTO userDTO)
        {
            Utilisateur u = _utilisateurRepository.Find(u => u.Email == userDTO.Username && u.Password == userDTO.Password);
            if(u != null)
            {
                return CreateToken(u);
            }
            return null;
        }

        private string CreateToken(Utilisateur utilisateur)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Expires = DateTime.Now.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "m2i",
                Audience = "m2i",
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("role", "admin"),
                        new Claim("username", utilisateur.Email)
                })
            };

            SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
