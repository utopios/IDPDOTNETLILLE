import { useSelector, useDispatch } from "react-redux";
import { useEffect, useState } from "react";
import { v4 as uuidv4 } from "uuid";
import { getArticle } from "../../Services/ArticleService";
import Card from "../../Components/Card/Card";
import './Home.css'
import { Link } from 'react-router-dom'

function Home() {
  
  const { articles } = useSelector((state) => ({
    ...state.articleReducer,
  }));

  const dispatch = useDispatch();

  useEffect(() => {
    if (articles.length === 0) {
      const data = getArticle().then(res => {
        console.log(res.data);
        dispatch({
          type: "LOADARTICLES",
          payload: res.data,
        });
      });
    }
  }, []);

  return (
    <>

      <h1 className="home-title">Tous les articles</h1>
      <div className="container-cards">
        {articles?.map((item) => {
          return (
            <Card >
              <h2>{item.title}</h2>
              <Link
                to={{
                  pathname: '/article',
                  state: {
                    title: item.title,
                    body: item.body
                  }
                }}
              >
                Lire l'article
              </Link>
            </Card>
          );
        })}
      </div>
    </>
  );
}

export default Home;
