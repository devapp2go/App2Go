import React, { Component } from 'react'
import "./styles/Elements.css"

export default class Element extends Component {
    render() {
        return (
            <div>
                <button class="element_button">
                    <img class="element_img"
                    src={process.env.PUBLIC_URL + "/media/img/text_element.png"}
                    />
                </button>
                <label>Información</label>
            </div>
        )
    }
}
