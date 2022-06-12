import React from "react";
import { Navbar, Nav } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

function PageNavbar() {
  const navigate = useNavigate();

  return (
    <Navbar bg="light" variant="light" expand="lg">
      <Navbar.Brand href="/">Team Lunch</Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse id="basic-navbar-nav">
        <Nav className="me-auto">
          <Link to="/about">
            <Nav.Link onClick={() => navigate("/about")}>About</Nav.Link>
          </Link>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default PageNavbar;
