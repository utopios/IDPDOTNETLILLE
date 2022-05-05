import { PureComponent } from "react"
import { getData } from "./services/data.service"
export class DataComponent extends PureComponent {
    constructor(props) {
        super(props)
        this.state = {
            data: []
        }

    }

    componentDidMount() {
        getData().then(data => {
            this.setState({ data: data });
        })
    }

    render() {
        return (
            <div>
                {
                    this.state.data.length == 0 ? <div>En cours ...</div>
                        :
                        (
                            <div>
                                {this.state.data.map((e, i) => (<div key={i}>{e}</div>))}
                            </div>
                        )
                }
            </div>
        )
    }
}