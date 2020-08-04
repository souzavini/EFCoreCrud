import React from 'react'
import NavBarItem from '../Components/navbarItem'



function Navbar() {
    return (
        <div>
            <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
                <a class="navbar-brand" href="#">Navbar</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarColor01">
                    <ul class="navbar-nav mr-auto">
                        <NavBarItem href="#home" label="Home"/>
                        <NavBarItem href="#produto" label="Produto"/>
                        <NavBarItem href="#vendas" label="Vendas"/>
                    </ul>
        </div>
        </nav>
        </div>
        )
    }
    export default Navbar;