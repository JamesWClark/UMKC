
function List(){ 

List.makeNode=function(){
 return {data:null,next:null};
};

this.start=null;
this.end=null;


this.add=function (data){
 if(this.start===null){
   this.start=List.makeNode();
   this.end=this.start;
 }
 else{
  this.end.next=List.makeNode();
  this.end=this.end.next;
 };

this.end.data=data;
};

}