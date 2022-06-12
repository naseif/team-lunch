import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import { Button, Nav } from "react-bootstrap";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

function App() {
  const navigate = useNavigate();

  return (
    <div className="text-center">
      <h1 className="display-6">Welcome to team lunch</h1>
      <Link to="/session">
        <Nav.Link onClick={() => navigate("/session")}>
          <Button variant="primary">Start a lunch session!</Button>{" "}
        </Nav.Link>
      </Link>{" "}
    </div>
  );
}

export default App;
