import { useState, useEffect } from "react";
import './App.css';

function App() {
    const [data, setData] = useState(null);

    useEffect(() => {
        fetch("http://localhost:5134/api/Usuario")
            .then((response) => response.json())
            .then((data) => setData(data));
    },[]);


  return (
    <div className="App">
          <h1>Hola!</h1>
          <div className="card">
              <ul>
                  {data?.map((usuario) => (
                      <li key={usuario.id}>{usuario.nombre}</li>
                      )) }
              </ul>
          </div>
    </div>
  );
}

export default App;
