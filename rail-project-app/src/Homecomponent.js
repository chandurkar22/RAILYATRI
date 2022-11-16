import React from 'react';
import MyComponent from './Mycomponent' ;
class HomeComponent extends React.Component 
 {
    constructor(props) {
        super(props);
        this.state ={
  
            fromstation : "",
            toStation : "",
            showtrainlist: false
          };
      }

    handleFromChange =(event)=> {
      this.setState({fromstation: event.target.value});
    }
  
    handleToChange =(event)=> {
      this.setState({toStation: event.target.value});
    }

    handleShowTrainList =(event)=> {
      event.preventDefault();
      event.stopPropagation();

        this.setState({showtrainlist: true});
      }
    render() {
  
        return (
          <div class="center">
            <form onSubmit={this.handleShowTrainList}>
              <label>
                From Station:
                <input type="text" value={this.state.fromstation} onChange={this.handleFromChange}/>
              </label>
              <label>
                To Station :
                <input type="text" value={this.state.toStation} onChange={this.handleToChange}/>
              </label>
              <label>
                Date:
                <input type="Date" />
              </label>
              <button type='submit' className='button'>Search</button>
            </form>
            {this.state.showtrainlist && (<MyComponent fromstation={this.state.fromstation} toStation={this.state.toStation}/>)}
          </div>
        )
      }
    
  }
  
  export default HomeComponent;