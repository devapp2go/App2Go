import React from 'react';
import { connect } from 'react-redux';

class Order extends React.Component {
    render() {
      return (
        <div>
            <p><strong>Producto: </strong> Fruta de Mango y Piña</p>
            <p><strong>Cliente: </strong> Victor Trejo</p>
            <p><strong>Direccion: </strong> Ricardo Palma 2933</p>
            <p><strong>Cantidad: </strong> 2</p>
            <p><strong>Total: </strong> 100 pesos</p>
            <p><strong>Instrucciones: </strong> Lorem ipsum dolor sit amet consectetur adipiscing elit,
             sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p>
             <button>Rappi</button>
             <button>Entregado</button>
        </div>
      );
    }
  }

  export default (Order);