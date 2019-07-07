import React, { Component } from 'react'
import "./styles/Elements.css"

export default class Element extends Component {

    constructor(props) {
        super(props);
        this.state = {isToggleOn: false};
    
        // This binding is necessary to make `this` work in the callback
        this.handleClick = this.handleClick.bind(this);
      }

    handleClick() {
        this.setState(state => ({
          isToggleOn: !state.isToggleOn
        }));
      }

    render() {
        return (
            <div>
                <button class="element_button" onClick={this.handleClick}>
                    <img class="element_img"
                    src={process.env.PUBLIC_URL + "/media/img/text_element.png"}
                    />
                    <img src={process.env.PUBLIC_URL + "/media/img/check_element.png"} class={this.state.isToggleOn ? '' : 'hidden'}/>

                </button>
                <label class="text">Información</label>
            </div>
        )
    }
}
