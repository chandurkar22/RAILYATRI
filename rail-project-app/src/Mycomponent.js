import React from 'react';
class MyComponent extends React.Component {
    constructor(props) {
      super(props);
      this.state = {
        trainList: [],
        error: null,
        isLoaded: false,
        items: [],
        fromstation: props.fromstation,
        toStation: props.toStation
      };
    }
  
    componentDidMount() {
      fetch("https://localhost:7298/get-list",
        {
          method: "POST",
          headers: {
            "Content-type": "application/json; charset=UTF-8"
          },
          body: JSON.stringify({
            fromstation : this.state.fromstation,
            toStation : this.state.toStation
          })
        })
        .then(res => res.json())
        .then(
          (result) => {
            this.setState({
              isLoaded: true,
              trainList: result
            });
            console.log(result)
          },
          // Note: it's important to handle errors here
          // instead of a catch() block so that we don't swallow
          // exceptions from actual bugs in components.
          (error) => {
            console.log(error);
            this.setState({
              isLoaded: true,
              error
            });
          }
        )
    }
  
    render() {
      const { error, isLoaded, items, trainList } = this.state;
      if (error) {
        return <div>Error: {error.message}</div>;
      } else if (!isLoaded) {
        return <div>Loading...</div>;
      } else {
        return (
  
          <ol>
            {trainList.map(train => (
              <li key={train.id}>
                
                <span style ={{paddingRight: '10px'}}>{train.trainname}</span> <span style ={{paddingRight: '10px'}}>{train.trainNumber}</span>
                <span style ={{paddingRight: '10px'}}>{new Date(train.trainSchedules[0].departureTime).toDateString()}</span> 
                <span style ={{paddingRight: '10px'}}>{new Date(train.trainSchedules[0].arrivalTime).toDateString()}</span>
                <span style ={{paddingRight: '10px'}}>{train.availabilitySchedules[0].class}</span>
                <span style ={{paddingRight: '10px'}}>{train.availabilitySchedules[0].amount}</span>
                <span style ={{paddingRight: '10px'}}>{train.availabilitySchedules[0].status}</span>
              </li>
              
            ))}
          </ol>
          
        );
      }
    }
  }
   
  export default MyComponent;