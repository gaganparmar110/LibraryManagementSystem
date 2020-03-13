import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class StudentDetailBase {

//#region studentId Prop
        @prop()
        studentId : number;
//#endregion studentId Prop


//#region studentName Prop
        @required()
        @maxLength({value:50})
        studentName : string;
//#endregion studentName Prop


//#region mobileNo Prop
        @required()
        mobileNo : any;
//#endregion mobileNo Prop


//#region email Prop
        @maxLength({value:50})
        email : string;
//#endregion email Prop


//#region city Prop
        @maxLength({value:50})
        city : string;
//#endregion city Prop


//#region qualification Prop
        @required()
        @maxLength({value:50})
        qualification : string;
//#endregion qualification Prop



}