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
                                 <div class="cArea">
                                  <el-card class="box-card1">
                                    <div slot="header" class="clearfix">
                                      <el-checkbox v-model="checked">頁面</el-checkbox>
                                      <el-button style="float: right; padding: 3px 0" type="text"></el-button>
                                    </div>
                                    <div v-for="(o,index) in ol" :key="o">
                                      <el-checkbox v-model="checked">{{ol[index]}}</el-checkbox>
                                    </div>
                                  </el-card>
                                  <div class="fiflterbtn">
                                    <button type="button" class="btn btn-primary">→</button>
                                    <button type="button" class="btn btn-primary">←</button>
                                 </div>

                                 <el-card class="box-card1">
                                    <div slot="header" class="clearfix">
                                      <el-checkbox v-model="checked">頁面</el-checkbox>
                                      <el-button style="float: right; padding: 3px 0" type="text"></el-button>
                                    </div>
                                    <div v-for="(o,index) in ol" :key="o">
                                      <el-checkbox v-model="checked">{{ol[index]}}</el-checkbox>
                                    </div>
                                  </el-card>
                                  </div> 
                              <div class="btn">
                                  <button type="button" class="btn btn-success">儲存</button>
  
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

