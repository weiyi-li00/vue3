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
                                        <el-input placeholder="請輸入内容"></el-input>
                                      </div>
                                      <div class="itemButton">
                                        <button type="button" class="btn btn-primary">新增</button>
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
                                          </tr>
                                          
                                          <tr>
                                            <td>MyActivity</td>
                                            <td><input type="checkbox" style="width15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>Customer_Info</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>History</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>Ticket</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>RC</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>Termcode</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>

                                          <tr>
                                            <td>Contact</td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                            <td><input type="checkbox" style="width:15px;height:15px;"></td>
                                          </tr>
                                      </table>
                                  
                                </div>
                                 





                             
       
                          </div>
                          <div class="tab-pane fade" id="pills-profile2" role="tabpanel">
                              <div class="pills-home2" id="searchArea">
                                <div class="search">
                                    <div class="itemGroup">
                                      <p>欄位名稱</p>
                                      <el-input placeholder="請輸入内容"></el-input>
                                    </div>
                                    <div class="itemButton">
                                      <button type="button" class="btn btn-primary">新增</button>
                                    </div>
                                </div>
                                <div class="srchContext">
                                  <el-card class="box-card" v-for="(card,index) in cards">
                                      <div slot="header" class="clearfix">
                                        <el-checkbox :type="card.checked">{{card.name}}</el-checkbox>
                                      </div>
                                      <div class="text-item">
                                        <span>名稱提示:</span>
                                        <input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm">{{card.value}}
                                        <div class="cardBtn">
                                          <button type="button" class="btn btn-secondary">修改</button>
                                          <button type="button" class="btn btn-success">確定</button>
                                        </div>
                                      </div>
                                  </el-card>

                                  
                              
                                </div>
                                <div class="btn">
                                  <button type="button" class="btn btn-success">儲存</button>
  
                                </div>
                              </div>
                                
                          </div>
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
        //cards:["CustomerID","CustomerName","Email","MemberID"],

        checked: true,
        
      }
    },
    
       
    methods: {
     
    },

} 
</script>

