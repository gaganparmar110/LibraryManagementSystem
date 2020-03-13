import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBookBase {

//#region bookTitle Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'bookTitle', keyColumn: false})
        bookTitle : string;
//#endregion bookTitle Prop


//#region bookName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'bookName', keyColumn: false})
        bookName : string;
//#endregion bookName Prop


//#region authorName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'authorName', keyColumn: false})
        authorName : string;
//#endregion authorName Prop


//#region copies Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'copies', keyColumn: true})
        copies : number;
//#endregion copies Prop

}