import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BookIssueBase {

//#region bookIssueId Prop
        @prop()
        bookIssueId : number;
//#endregion bookIssueId Prop


//#region studentId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        studentId : number;
//#endregion studentId Prop


//#region bookDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        bookDetailId : number;
//#endregion bookDetailId Prop


//#region issueDate Prop
        @required()
        issueDate : any;
//#endregion issueDate Prop


//#region returnDate Prop
        @required()
        returnDate : any;
//#endregion returnDate Prop







}