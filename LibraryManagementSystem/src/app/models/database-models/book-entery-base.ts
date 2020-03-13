import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BookEnteryBase {

//#region bookEnteryId Prop
        @prop()
        bookEnteryId : number;
//#endregion bookEnteryId Prop


//#region bookTitle Prop
        @required()
        @maxLength({value:50})
        bookTitle : string;
//#endregion bookTitle Prop


//#region bookName Prop
        @required()
        @maxLength({value:50})
        bookName : string;
//#endregion bookName Prop


//#region copies Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        copies : number;
//#endregion copies Prop



}