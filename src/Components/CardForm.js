import React from 'react'

class CardForm extends React.Component {
    render() {
        return (
            <div className="container" style={{padding:'20px'}}>
                <div className="row">
                    <div className="card md-3 col-md-6" style={{ position: 'relative', left: '300px' }}>
                        <h3 className="card-header">{this.props.legend}</h3>
                        <div className="card-body">
                            <div className="row">
                                <div className="col-md-6">
                                    <div className="bs-component"></div>
                                    {this.props.children}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}
export default CardForm;