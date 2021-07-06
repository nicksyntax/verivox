import React, { Component } from 'react';
import { Table } from 'react-bootstrap';

export class Products extends Component {

    constructor(props) {
        super(props);
        this.state = { products: [] }
    }

    refreshList() {
        fetch(process.env.REACT_APP_VERIVOX_API + 'product')
            .then(response => response.json())
            .then(data => {
                this.setState({ products: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    // componentDidUpdate(){
    //     this.refreshList();
    // }

    render() {
        let baseCostBased = 1
        const { products } = this.state;
        return (
            <div className="appWrapper">
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Tariff Name</th>
                            <th>Tariff Type</th>
                            <th>Annal Consumption Allowance</th>
                            <th>Monthly Base Cost</th>
                            <th>Billing</th>
                            <th>Additional Consumption Cost</th>
                        </tr>
                    </thead>
                    <tbody>
                        {products.map(prod =>
                            <tr key={prod.productId}>
                                <td>
                                    {prod.productName}
                                </td>
                                <td>
                                    {prod.productTypeName}
                                </td>
                                <td>
                                    {prod.consumptionThreshold ? prod.consumptionThreshold + ' kWh/year' : '-'}
                                </td>
                                <td>
                                    {prod.monthlyBaseValue ? prod.monthlyBaseValue + ' €' : '-'}
                                </td>
                                <td>
                                    {prod.cost + (prod.productTypeId == baseCostBased ? ' cent/kWh' : ' €/year')}
                                </td>
                                <td>
                                    {prod.additionalCostPerKwh ? prod.additionalCostPerKwh + ' cent/kWh' : '-'}
                                </td>
                            </tr>
                        )}
                    </tbody>
                </Table>
            </div>
        )
    }
}