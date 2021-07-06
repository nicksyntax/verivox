import React from 'react';
import { Table } from 'react-bootstrap';


function ProductsTariffComparison(props) {
    const tariffComparisons = props.tariffs.map((tariff, index) => {
        return (
            <tr key={index}>
                <td>
                    {tariff.productName}
                </td>
                <td>
                    {tariff.annualCost + ' €'}
                </td>
            </tr>
        );
    });

    return (
        <Table className="mt-4" striped bordered hover size="sm">
            <thead>
                <tr>
                    <th>Tariff Name</th>
                    <th>Annual costs (€/year)</th>
                </tr>
            </thead>
            <tbody>
                {tariffComparisons}
            </tbody>
        </Table>
    );
}

export default ProductsTariffComparison;