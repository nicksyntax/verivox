import React, { Component } from 'react';
import { Button, Col, Form, FormControl } from 'react-bootstrap';
import ProductsTariffComparison from './ProductsTariffComparison';

export class Consumption extends Component {

    constructor(props) {
        super(props);
        this.state = { tariffs: [] }
    }

    //event binding
    calcConsumption = event => {
        event.preventDefault();
        fetch(process.env.REACT_APP_VERIVOX_API + 'product/' + event.target.consumption.value)
            .then(res => res.json())
            .then((result) => {
                this.setState({ tariffs: result });
            },
                (error) => {
                    alert('Failed');
                })
    }

    render() {
        return (
            <div className="appWrapper" >
                <Col md="6">
                    <Form onSubmit={this.calcConsumption} >
                        <Form.Group>
                            <Form.Row >
                                <Col>
                                    <Form.Label>
                                        Consumption (kWh/year)
                                    </Form.Label>
                                    <FormControl name="consumption" type="number" placeholder="kWh/year" />
                                </Col>
                            </Form.Row >
                        </Form.Group>
                        <Form.Group>
                            <Form.Row>
                                <Col>
                                    <Button type="submit" size="sm" className="btn-danger">Compare Products</Button>
                                </Col>
                            </Form.Row>
                        </Form.Group>
                    </Form>
                </Col>
                {this.state.tariffs.length > 0 &&
                    <ProductsTariffComparison tariffs={this.state.tariffs} />
                }
            </div>
        )
    }
}