import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { events: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderEventsTable(events) {
        return (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Date</th>
                        <th>Count</th>
                    </tr>
                </thead>
                <tbody>
                    {events.map(event =>
                        <tr key={event.id}>
                            <td>{event.name}</td>
                            <td>{event.date}</td>
                            <td>{event.count}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderEventsTable(this.state.events);
        
        return (
            <div>
                <h1 id="tableLabel">Events</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateData() {
        console.log("Started loading");
        const response = await fetch('event');
        const data = await response.json();
        console.log(response);
        console.log("Finished loading");
        this.setState({ events: data, loading: false });
    }
}

