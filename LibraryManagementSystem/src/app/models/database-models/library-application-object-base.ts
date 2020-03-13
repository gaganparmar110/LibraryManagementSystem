import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class LibraryApplicationObjectBase {

//#region applicationObjectId Prop
        @prop()
        applicationObjectId : number;
//#endregion applicationObjectId Prop


//#region applicationObjectName Prop
        @required()
        @maxLength({value:50})
        applicationObjectName : string;
//#endregion applicationObjectName Prop


//#region applicationObjectTypeId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        applicationObjectTypeId : number;
//#endregion applicationObjectTypeId Prop



}