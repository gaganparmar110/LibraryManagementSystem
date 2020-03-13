import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BookDetailBase {

//#region bookDetailId Prop
        @prop()
        bookDetailId : number;
//#endregion bookDetailId Prop


//#region bookEnteryId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        bookEnteryId : number;
//#endregion bookEnteryId Prop


//#region authorName Prop
        @required()
        @maxLength({value:50})
        authorName : string;
//#endregion authorName Prop





}