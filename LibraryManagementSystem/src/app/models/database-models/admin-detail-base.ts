import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class AdminDetailBase {

//#region adminId Prop
        @prop()
        adminId : number;
//#endregion adminId Prop


//#region name Prop
        @required()
        @maxLength({value:50})
        name : string;
//#endregion name Prop


//#region userName Prop
        @required()
        @maxLength({value:50})
        userName : string;
//#endregion userName Prop


//#region password Prop
        @required()
        @maxLength({value:132})
        password : any;
//#endregion password Prop


//#region salt Prop
        @required()
        @maxLength({value:140})
        salt : any;
//#endregion salt Prop

}