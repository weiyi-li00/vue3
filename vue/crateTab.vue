<template>
    <div class="wrap">

                    <ul class="nav nav-pills mb-3" id="pills-tab" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="pills-home-tab" data-bs-toggle="pill" data-bs-target="#pills-home" type="button" role="tab" aria-controls="pills-home" aria-selected="true">新增</button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="pills-profile-tab" data-bs-toggle="pill" data-bs-target="#pills-profile" type="button" role="tab" aria-controls="pills-profile" aria-selected="false">狀態</button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="pills-contact-tab" data-bs-toggle="pill" data-bs-target="#pills-contact" type="button" role="tab" aria-controls="pills-contact" aria-selected="false">搜尋</button>
                      </li>
                    </ul>
                    <div class="tab-content" id="pills-tabContent">
                      <div class="tab-pane fade show active" id="pills-home" role="tabpanel" aria-labelledby="pills-home-tab">
                          <div class="pills-home2">
                            <div class="groupItem">

                              <div class="itemGroup">
                                <span><span class="mak">*</span>專案名稱</span><br>
                                <el-input placeholder="請輸入内容" v-model='projtName'></el-input>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>專案代碼</span><br>
                                <el-input placeholder="請輸入内容" v-model='projtNum'></el-input>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>Application_id</span><br>
                                <div class="input-group mb-3">
                                    <select class="form-select" id="inputGroupSelect01">
                                        <option selected v-for=" (id,index) in Application">
                                          {{Application[index]}}
                                        </option>
                                    </select>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>GroupID</span><br>
                                <select class="form-select" id="inputGroupSelect01">
                                        <option selected v-for=" (g,index) in GroupID">
                                          {{GroupID[index]}}
                                        </option>
                                </select>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>HTML資料夾名稱</span><br>
                                <el-input placeholder="請輸入内容" v-model='htmlName'></el-input>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>通知人員</span><br>
                                 <select class="form-select" id="inputGroupSelect01">
                                        <option selected v-for=" (s,index) in staff">
                                          {{staff[index]}}
                                        </option>
                                  </select>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak"></span>共用個資檔案</span><br>
                                <el-autocomplete popper-class="my-autocomplete" placeholder="請輸入内容">
                              </div>
                            </div>
                            <div class="groupItem">
                              <div class="itemGroup">
                                <span><span class="mak">*</span>專案類型</span><br>
                                <div class="radio">

                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1">
                                  <label class="form-check-label" for="inlineRadio1">IB</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="OB" value="option1">
                                  <label class="form-check-label" for="OB">OB</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="TM" value="option1">
                                  <label class="form-check-label" for="TM">TM</label>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>站台</span><br>
                                <div class="radio">

                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="TP" value="option1">
                                  <label class="form-check-label" for="TP">TP</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="SH" value="option1">
                                  <label class="form-check-label" for="SH">SH</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="NJ" value="option1">
                                  <label class="form-check-label" for="NJ">NJ</label>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <span><span class="mak">*</span>語系</span><br>
                                <div class="radio">

                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="TW" value="option1">
                                  <label class="form-check-label" for="TW">TW</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="CH" value="option1">
                                  <label class="form-check-label" for="CH">CH</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="EN" value="option1">
                                  <label class="form-check-label" for="EN">EN</label>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <spanp><span class="mak">*</span>系統別</spanp><br>
                                <div class="radio">

                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="G5" value="option1">
                                  <label class="form-check-label" for="G5">G5</label>
                                  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="UIP" value="option1">
                                  <label class="form-check-label" for="UIP">UIP</label>
                                </div>
                                
                              </div>
                              
                              <div class="itemGroup">
                                <span>QOC</span><br>
                                <div class="ocArea">
                                  <span>顯示:</span>
                                  <el-switch v-model="value1" active-text="是" inactive-text="否"></el-switch>
                                </div>
                                <div class="ocArea">
                                  <span>名稱:</span>
                                  <el-input placeholder="請輸入内容" v-model='QOC'></el-input>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <span>AOC</span><br>
                                <div class="ocArea">
                                  <span>顯示:</span>
                                  <el-switch v-model="value2" active-text="是" inactive-text="否"></el-switch>
                                </div>
                                <div class="ocArea">
                                  <span>名稱:</span>
                                  <el-input placeholder="請輸入内容" v-model='AOC'></el-input>
                                </div>
                              </div>
                            </div> 
                            <div class="groupItem">
                              <div class="itemGroup">
                                <span>文字大小</span>
                                <div class="ocArea">
                                  <el-input placeholder="數字" type="number" min="13"></el-input>
                                  <small>系統預設 : 13px</small>

                                </div>
                              </div>
                              <div class="itemGroup">
                                <span>字型</span>
                                <div class="ocArea">
                                  <el-input placeholder="請輸入内容" v-model="textType"></el-input>

                                  <small>微軟正黑體/新宋體</small>
                                </div>
                              </div>
                              <div class="itemGroup">
                                <div class="ocArea">
                                  <span>進線搜尋客戶</span>
                                  <el-switch v-model="value3" active-text="是" inactive-text="否"></el-switch>

                                </div>
                              </div>
                            </div> 
                            <div class="btn">
                              <button type="button" class="btn btn-success">儲存</button>
  
                            </div>
                          </div>
                      </div><!--頁簽1-->
                      <div class="tab-pane fade" id="pills-profile" role="tabpanel">
                        <div class="pills-content">
                          <div class="pillsGroup" id="time">
                            <div class="groupItem">
                              <div class="block">
                                <span class="demonstration">上架日期</span>
                                <el-date-picker v-model="date1" type="date" placeholder="選擇日期" ></el-date-picker>
                              </div>
                            </div>
                            <div class="groupItem">
                            <div class="block">
                              <span class="demonstration">下架日期</span>
                              <el-date-picker v-model="date2" type="date" placeholder="選擇日期" ></el-date-picker>
                            </div>
                            </div>
                          </div>
                          <div class="pillsGroup">
                            <div class="groupItem">
                              <el-upload class="upload-demo" drag action="https://jsonplaceholder.typicode.com/posts/" multiple>
                              <i class="el-icon-upload"></i>
                              <div class="el-upload__text">將文件拖到此處，或<em>點擊上傳</em></div>
                              <template #tip>
                                <div class="el-upload__tip">
                                  只能上傳 jpg/png 文件，且不超過 500kb
                                </div>
                              </template>
                            </el-upload>
                            </div>
                            <div class="groupItem" id="IB">
                                <span>專案啟用</span>
                                <el-switch v-model="value4" active-text="是" inactive-text="否"></el-switch>
                            </div>
                          </div>

                        </div>
                        <div class="btn" style="width: 100%;">
                          <button type="button" class="btn btn-success" id="btn-success">儲存</button>
  
                        </div>  
                      </div><!--頁簽2-->
                      <div class="tab-pane fade" id="pills-contact" role="tabpanel" aria-labelledby="pills-contact-tab">
                        <div class="pills-home2" id="searchArea">
                            <div class="search">
                              <div class="itemGroup">
                                <p>狀態</p>
                                <select class="form-select" id="inputGroupSelect01" v-model="option2">
                                        <option  v-for=" (t,index) in  status">
                                          {{status[index]}}
                                        </option>
                                </select>
                              </div>
                              <div class="itemGroup">
                                <p>類型</p>
                                <select class="form-select" id="inputGroupSelect01" v-model="option">
                                        <option  v-for=" (p,index) in type">
                                          {{type[index]}}
                                        </option>
                                </select>
                              </div>
                              <div class="itemGroup">
                                <p>名稱</p>
                                <el-input placeholder="請輸入内容" v-model.trim="searchFilter" type="text"></el-input>
                              </div>
                              <div class="itemButton">
                                <button type="button" class="btn btn-primary" v-on:click='srchPrjt(option,option2)'>搜尋</button>
                              </div>                                          
                            </div>
                            <div class="srchContext">
                              <div class="card"  v-for="(prj,index) in projects">
                                <img v-bind:src="prj.img" class="card-img-top" alt="logo">
                                  <p class="card-text">{{prj.name}}</p>
                                <div class="card-body">
                                  <span class="ot">{{prj.status}}</span>
                                  <span class="ot">{{prj.type}}</span>
                                </div>
                              </div>  
                            </div>
                        </div>
                      </div><!--頁簽3-->
                     </div>
    </div>
</template>

<script>
export default {
  data() {
    return{
      option2:'',
      option:'',
      textType:'',
      QOC:'',
      AOC:'',
      projtName:'',
      projtNum:'',
      htmlName:'',
       value1 : true,
       value2 : true,
       value3 : true,
       value4 : true,//啟用專案
       date1 :  true,
       date2 :  true,
       Application :['Abbott(53)','Brands(30004)',
        'CW(33)','Huawei_HK(20)','Nexstgo(9993)','PG_CN(30)','Y100(12)'],
      
      GroupID:["Viantest(9993)", "skill(61)","udn_TW(93)"],
      staff : ["Scott","Scott","Scott"],
      status: { all:"" ,on:"上線", down:"下線"},
      type : ["","IB", "OB"],
      searchFilter : '',
      projects : [
        {name:'volvo'       , img:'#', status:'上線' ,type:'IB'},
        {name:'CW_OB'       , img:'#', status:'下線' ,type:'OB'},
        {name:'ECOVACS_HK'  , img:'#', status:'上線' ,type:'OB'},
        {name:'DST'         , img:'#', status:'下線' ,type:'OB'},
        {name:'HERE-TW'     , img:'#', status:'上線' ,type:'IB'},
        {name:'iAPOTel'     , img:'#', status:'下線' ,type:'IB'},
        {name:'KFC'         , img:'#', status:'下線' ,type:'IB'},
        {name:'Nespresso_CN', img:'#', status:'上線' ,type:'OB'}
        ],

        projects1 : [
        {name:'volvo'       , img:'#', status:'上線' ,type:'IB'},
        {name:'CW_OB'       , img:'#', status:'下線' ,type:'OB'},
        {name:'ECOVACS_HK'  , img:'#', status:'上線' ,type:'OB'},
        {name:'DST'         , img:'#', status:'下線' ,type:'OB'},
        {name:'HERE-TW'     , img:'#', status:'上線' ,type:'IB'},
        {name:'iAPOTel'     , img:'#', status:'下線' ,type:'IB'},
        {name:'KFC'         , img:'#', status:'下線' ,type:'IB'},
        {name:'Nespresso_CN', img:'#', status:'上線' ,type:'OB'}
        ]
    }  
      
  },
   
    methods: {
      srchPrjt(i,o){
        console.log(526+56)
        this.projects = this.projects1.filter((item, index) => {
            return (item.type === i || i === '')  &&  (item.status === o || o === '') 
            
           
      });
      }
    },
      computed:{
      projects(){
        return this.projects.filter((item, index) => {
          return item.name.toLowerCase().includes(this.searchFilter.toLowerCase())
        });
      },
      

      
    }
}

</script>