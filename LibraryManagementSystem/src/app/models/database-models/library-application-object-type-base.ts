import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class LibraryApplicationObjectTypeBase {

//#region applicationObjectTypeId Prop
        @prop()
        applicationObjectTypeId : number;
//#endregion applicationObjectTypeId Prop


//#region applicationObjectTypeName Prop
        @required()
        @maxLength({value:50})
        applicationObjectTypeName : string;
//#endregion applicationObjectTypeName Prop



}