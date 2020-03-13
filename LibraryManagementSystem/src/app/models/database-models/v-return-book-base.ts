import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vReturnBookBase {

//#region studentName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'studentName', keyColumn: false})
        studentName : string;
//#endregion studentName Prop


//#region bookTitle Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'bookTitle', keyColumn: false})
        bookTitle : string;
//#endregion bookTitle Prop


//#region bookName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'bookName', keyColumn: false})
        bookName : string;
//#endregion bookName Prop


//#region returnDate Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'returnDate', keyColumn: false})
        returnDate : any;
//#endregion returnDate Prop


//#region mobileNo Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'mobileNo', keyColumn: true})
        mobileNo : any;
//#endregion mobileNo Prop


//#region returnStatusAO Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'returnStatusAO', keyColumn: false})
        returnStatusAO : any;
//#endregion returnStatusAO Prop

}