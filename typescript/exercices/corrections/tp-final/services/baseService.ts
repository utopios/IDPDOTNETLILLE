import {readFileSync, writeFileSync} from "fs"
import { BaseClass } from "../classes/base"

export class BaseService<T extends BaseClass> {
    data:Array<T> = []
    count:number
    file:string
    constructor(file) {
        this.data = []
        this.count = 0
        this.file = file
    }

    readFromJson():void {
        const dataString:string = readFileSync(this.file).toString()
        this.data = JSON.parse(dataString)
        this.count = this.data.length > 0 ? this.data[this.data.length-1].id : 0
    }

    writeToJson():void {
        writeFileSync(this.file, JSON.stringify(this.data))
    }
}

