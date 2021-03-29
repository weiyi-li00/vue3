<template>
    <div class="wrap">
                      <ul class="nav nav-pills mb-3" id="pills-tab" role="tablist">
                          <li class="nav-item" role="presentation">
                            <button class="nav-link active" id="pills-home-tab" data-bs-toggle="pill" data-bs-target="#pills-home" type="button" role="tab" aria-controls="pills-home" aria-selected="true">Permission</button>
                          </li>
                          <li class="nav-item" role="presentation">
                            <button class="nav-link" id="pills-profile-tab" data-bs-toggle="pill" data-bs-target="#pills-profile" type="button" role="tab" aria-controls="pills-profile" aria-selected="false">CustomerSet</button>
                          </li>
                      </ul>
                        <div class="tab-content" id="pills-tabContent">
                          <div class="tab-pane fade show active" id="pills-home" role="tabpanel" aria-labelledby="pills-home-tab">
                              <div class="pills-home2">
                              <el-transfer filterable :filter-method="filterMethod" filter-placeholder="请输入城市拼音" v-model="value" :data="data">
                                
                              </el-transfer>
                              <br>
                              <el-card class="box-card">
                                  <div slot="header" class="clearfix">
                                    <span>頁面</span>
                                    
                                  </div>
                                  <div v-for="o in 4" :key="o" class="text item">
                                      {{'列表内容 ' + o }}
                                  </div>
                              </el-card>

                              </div>
                          </div>
                          <div class="tab-pane fade" id="pills-profile" role="tabpanel" aria-labelledby="pills-profile-tab">...
                              <div class="pills-home2">
                              <div class="search">
                                  <div class="itemGroup">
                                    <p>欄位名稱</p>
                                    <el-input placeholder="請輸入内容"></el-input>
                                  </div>
                                  <div class="itemButton">
                                    <button type="button" class="btn btn-primary">新增</button>
                                  </div>
                              </div>

                              </div>
                          </div>
                          
                        </div> 
                         
    </div>
</template>

<script>
export default{
    data() {
      const generateData = _ => {
        const data = [];
        const cities = ['MyActivity', 'Customer_Info', 'History', 'Ticket', 'RC','TermCode','Contact','ContactEmail (95)'];
        const pinyin = ['MyActivity', 'Customer_Info', 'History', 'Ticket', 'RC','TermCode','Contact','ContactEmail (95)'];
        cities.forEach((city, index) => {
          data.push({
            label: city,
            key: index,
            pinyin: pinyin[index]
          }); 
        });
        return data;
      };
      return {
        data: generateData(),
        value: [],
        filterMethod(query, item) {
          return item.pinyin.indexOf(query) > -1;
        }
      };
    }
  

} 
</script>
<style scoped>
.el-transfer-panel{
  width: 280px;
}
</style>
