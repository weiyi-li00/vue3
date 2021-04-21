<template>
    <div class="wrap">
                        <ul class="nav nav-pills mb-3" id="pills-tab2" role="tablist">
                            <li class="nav-item" role="presentation">
                              <button class="nav-link active" id="pills-home2-tab" data-bs-toggle="pill" data-bs-target="#pills-home2" type="button" role="tab" aria-controls="pills-home2" aria-selected="true">Permission</button>
                            </li>
                            <li class="nav-item" role="presentation">
                              <button class="nav-link" id="pills-profile2-tab" data-bs-toggle="pill" data-bs-target="#pills-profile2" type="button" role="tab" aria-controls="pills-profile2" aria-selected="false">CustomerSet</button>
                            </li>
                        </ul>
                        <div class="tab-content" id="pills-tabContent2">
                          <div class="tab-pane fade show active" id="pills-home2" role="tabpanel">
                                <div class="pills-home2" id="searchArea">
                                  <div class="search">
                                      <div class="itemGroup">
                                        <p>增加欄位</p>
                                        <el-input  v-model.trim="value" type="text"></el-input>
                                      </div>
                                      <div class="itemButton">
                                        <button type="button" class="btn btn-primary" v-on:click="add(value)">新增</button>
                                        <button type="button" class="btn btn-outline-info" style="margin-left: 150px;width: 85px;">參考</button>
                                        <button type="button" class="btn btn-success" style="margin-left: 150px;width: 85px;">儲存</button>
                                      </div>
                                  </div>
                                      <table id="team" style="table-layout: fixed;">
                                          <tr id="first">
                                            <td>選單</td>
                                            <td>Agent(0)</td>
                                            <td>UH(5)</td>
                                            <td>OM(6)</td>
                                            <td>SD(9)</td>
                                            <td>P&C(10)</td>
                                            <td>PS(11)</td>
                                            <td>全選</td>
                                            <td>刪除</td>
                                          </tr>
                                          
                                          <tr v-for="(data ,index) in datas">
                                            <td v-model="data.name"><input type="text" v-bind:value="data.name"></td>
                                            <td ><input type="checkbox" v-model="data.Agent" v-on:change='itemcheck(index)'></td>
                                            <td ><input type="checkbox" v-model="data.UH" v-on:change='itemcheck(index)'></td>
                                            <td ><input type="checkbox" v-model="data.OM" v-on:change='itemcheck(index)'></td>
                                            <td ><input type="checkbox" v-model="data.SD" v-on:change='itemcheck(index)'></td>
                                            <td ><input type="checkbox" v-model="data.PC" v-on:change='itemcheck(index)'></td>
                                            <td ><input type="checkbox" v-model="data.PS" v-on:change='itemcheck(index)'></td>
                                            <td><input type="checkbox" v-model="data.All" v-on:change='checkedAll(index)'></td>
                                             <td ><img src="img/dustbin.png" alt="" style="width:25px" class="trush" v-on:click="datas.splice(index,1)"></td>
                                          </tr>
                                      </table>
                                      
                                </div>
                                 





                             
       
                          </div> <!--permission結束  -->
                         
                          <div class="tab-pane fade" id="pills-profile2" role="tabpanel">
                              <div class="pills-home2" id="searchArea">
                                <div class="search">
                                    <div class="itemGroup">
                                      <p>欄位名稱</p>
                                      <el-input placeholder="請輸入内容" v-model.trim="column"></el-input>
                                    </div>
                                    <div class="itemButton">
                                      <button type="button" class="btn btn-primary" v-on:click="add2(column)">新增</button>
                                    </div>
                                </div>
                                <div class="srchContext" >
                                  <div v-on:dragover='dragover' v-on:drop='dragdrop(index)' v-for="(card,index) in cards"> 
                                  <el-card :id="index" class="box-card"   draggable="true" v-on:dragstart='dragstart(index)' v-on:dragend='dragend'>
                                      <div slot="header" class="clearfix">
                                        <el-button type="text">{{card.name}}</el-button>
                                      </div>
                                      <div class="text-item">
                                        <span>名稱提示:{{card.value}}</span>
                                        <input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm" v-model="card.value">
                                        <div class="cardBtn">
                                          <button type="button" class="btn btn-secondary" v-on:click="card.value=''">修改</button>
                                          <button type="button" class="btn btn-danger" v-on:click="del(index)">刪除</button>
                                        </div>
                                      </div>
                                  </el-card>
                                  </div>
                                </div>
                                <div class="btn">
                                  <button type="button" class="btn btn-success">儲存</button>
  
                                </div>
                              </div>
                                
                          </div><!--CustomerSet結束  -->
                        </div>

                          
                        
                         
    </div>
</template>

<script>

export default{
    
    data() {
     
      return {
        cards:[
        {name:"Phone", checked: true, value:""},
        {name:"CustomerID", checked: true, value:""},
        {name:"CustomerName", checked: true, value:""},
        {name:"Email", checked: true, value:""},
        {name:"MemberID",checked: true, value:""}
        ],
        
        datas:[
        {name:"MyActivity", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"Customer_Info", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"History", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"Ticket", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"RC", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"Termcode", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        {name:"Contact", Agent: false, UH: false,OM: false,
          SD: false, PC: false,PS: false, All: false},
        ],
        ckecked:false,
        listItem: [],
        card:0,
        value:'',
        column:'',
        
        
      }
    },
  methods: {
         dragstart(index){
           this.card=index;
           //console.log(index);
         },
         dragend(e){
           //console.log(2);
         },
         dragover(e){
           e.preventDefault();
           console.log('over');
         },
         dragdrop(index){
           //e.preventDefault();
           //index.push(this.card);
           if(this.card>index){
          this.cards.splice(index,0,this.cards[this.card]);
           this.cards.splice(this.card+1,1);
           }
           else{
           this.cards.splice(index+1,0,this.cards[this.card]);
           this.cards.splice(this.card,1);
           }
           console.log(this.card);//抓取的資料
           console.log(index);//被換位子的資料
           
         },
         checkedAll(index){
           
           if(this.datas[index].All){
             this.datas[index].Agent = true;
             this.datas[index].UH = true;
             this.datas[index].OM = true;
             this.datas[index].SD = true;
             this.datas[index].PC = true;
             this.datas[index].PS = true;
             console.log(22);
           }
             
         },
         itemcheck(index){
           console.log(22);
           let name=['Agent', 'UH','OM','SD', 'PC','PS'];
           let sum = 0;
           for(let i = 0; i<name.length; i++){
             if(this.datas[index][name[i]] == true){
               sum++;
               
             }
             
           }
           if(sum===6){
             this.datas[index].All = true;
           }else{
             this.datas[index].All = false;
           }
         },
         add(value){
           let addItem = {name:this.value, Agent: false, UH: false, OM: false,
           SD: false, PC: false,PS: false, All: false};
           this.datas.push(addItem);
         },
         add2(column){
           let addcolumn = {name:this.column, checked: true, value:""};
           this.cards.push(addcolumn);
         },
        del(index){
           this.cards.splice(index,1);
         },
         
         
         
  },
  

} 

</script>

