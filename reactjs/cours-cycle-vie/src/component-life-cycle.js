import {Component, PureComponent} from "react"
export class ComponentLife extends PureComponent {
    constructor(props) {
        super(props)
        console.log("1- first step - construction")
        this.state = {
            status : false
        }
    }

    render() {
        console.log("2- Second step - render")
        return(
            <div>
                <h1>Rendu</h1>
                <button onClick={() => this.setState({status: !this.state.status}) }>Change State</button>
            </div>
        )
    }

    componentDidMount() {
        console.log("3 -- 3th Step - end mouting")
    }

    // shouldComponentUpdate(nextProps, nextState) {
    //     return nextState.status != this.state.status
    // }
    
    componentDidUpdate() {
        console.log("4- 4th step - end of update")
    }

    componentWillUnmount() {
        console.log("5- 5th step - before unmount of component")
    }
}