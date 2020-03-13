import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BookReturnBase {

//#region bookReturnId Prop
        @prop()
        bookReturnId : number;
//#endregion bookReturnId Prop


//#region bookIssueId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        bookIssueId : number;
//#endregion bookIssueId Prop


//#region returnStatusAO Prop
        @prop()
        returnStatusAO : number;
//#endregion returnStatusAO Prop



}