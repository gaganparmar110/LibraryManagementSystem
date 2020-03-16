import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBookIssueBase {

//#region studentName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'studentName', keyColumn: false})
        studentName : string;
//#endregion studentName Prop


//#region bookName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'bookName', keyColumn: false})
        bookName : string;
//#endregion bookName Prop


//#region authorName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'authorName', keyColumn: false})
        authorName : string;
//#endregion authorName Prop


//#region mobileNo Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'mobileNo', keyColumn: true})
        mobileNo : any;
//#endregion mobileNo Prop


//#region issueDate Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'issueDate', keyColumn: false})
        issueDate : any;
//#endregion issueDate Prop


//#region returnDate Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'returnDate', keyColumn: false})
        returnDate : any;
//#endregion returnDate Prop


//#region bookIssueId Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'bookIssueId', keyColumn: true})
        bookIssueId : number;
//#endregion bookIssueId Prop

}