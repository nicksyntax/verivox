import React, { Component } from 'react';
import { NavLink } from 'react-router-dom';
import { Navbar, Nav } from 'react-bootstrap';

export class Navigation extends Component {
    render() {
        return (
            <Navbar className="mb-4 navbar navbar-expand-lg navbar-dark red darken-2" bg="warning" variant="light">
                <Navbar.Brand  to="/" className="navbar-brand font-bold">Verivox</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="nav-item">
                        <NavLink className="nav-link waves-effect waves-light" to="/">
                            Home
                        </NavLink>
                        <NavLink className="nav-link waves-effect waves-light" to="/Products">
                            Products
                        </NavLink>
                        <NavLink className="nav-link waves-effect waves-light" to="/Consumption">
                            Consumption
                        </NavLink>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        )
    }
}