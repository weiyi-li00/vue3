<template>
  <div class="wrap">
    <ul class="nav nav-pills mb-3" id="pills-tab3" role="tablist">
      <li class="nav-item" role="presentation">
        <button class="nav-link active" id="pills-home-tab3" data-bs-toggle="pill" data-bs-target="#pills-home3" type="button" role="tab" aria-controls="pills-home" aria-selected="true">
          NoBar
        </button>
      </li>
      <li class="nav-item" role="presentation">
        <button class="nav-link" id="pills-profile-tab3" data-bs-toggle="pill" data-bs-target="#pills-profile3" type="button" role="tab" aria-controls="pills-profile" aria-selected="false">
          TeamCode
        </button>
      </li>
    </ul>
    <div class="tab-content" id="pills-tabContent3">
      <div class="tab-pane fade show active" id="pills-home3" role="tabpanel" aria-labelledby="pills-home-tab3">
        <div class="pills-home2">
          <div class="search">
            <div class="itemGroup">
              <p>資料庫</p>
              <select class="form-select" id="inputGroupSelect01">
                <option selected v-for="(d, index) in DB">
                  {{ DB[index] }}
                </option>
              </select>
            </div>
            <div class="itemButton">
              
                <el-button @click="drawer = true" type="primary" style="margin-left: 16px;">
                  新增
                </el-button>

              

              <el-drawer v-model="drawer">
                <el-input placeholder="搜尋" prefix-icon="el-icon-search"></el-input>
                <el-table :data="tableData" :row-class-name="tableRowClassName">
                  <el-table-column width="90px">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                  </el-table-column>
                  <el-table-column prop="site" label="Site" width="110px"></el-table-column>
                  <el-table-column prop="systype" label="SysType" width="110px"></el-table-column>
                  <el-table-column prop="name" label="服務" width="200px"></el-table-column>
                  
                </el-table>
                <button type="button" class="btn btn-primary" style="width: 63px; float: right; margin-top:20px">確定</button>
              </el-drawer>  
                    
          
             
            </div>
          </div>
        </div>
        <div class="contentA">
              <el-table :data="tableData" :row-class-name="tableRowClassName" style="width:85%; margin:0 auto;">
                <el-table-column prop="site" label="Site" width="200px"></el-table-column>
                <el-table-column prop="systype" label="SysType" width="200px"></el-table-column>
                <el-table-column prop="name" label="服務" width="300px"></el-table-column>
                <el-table-column label="顯示名稱" width="300px"><input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"></el-table-column>
                <el-table-column label="" width="150px"><img src="vue\img\dustbin.png" alt="" style="width: 20px"></el-table-column>
              </el-table>
        </div>
        <div class="btn">
              <button type="button" class="btn btn-success">儲存</button>
  
        </div>
      </div>

      <div class="tab-pane fade" id="pills-profile3" role="tabpanel" aria-labelledby="pills-profile-tab3">
        <div class="pills-home2" style="flex-direction: column;">
          <div class="search">
            <div class="itemGroup" style="align-self: flex-end;margin: 15px 30px">
              <select class="form-select" id="inputGroupSelect01">
                <option selected v-for="(f,index) in filed">
                  {{ filed[index] }}
                </option>
              </select>
            </div>
            <div class="itemGroup2" style="align-self: flex-end;">
               <el-input placeholder="搜尋" prefix-icon="el-icon-search"></el-input>
            </div>
            <div class="itemGroup2">
                <span>新增資料夾</span>
                <el-input placeholder="請輸入内容" style="margin-top: 5px;"></el-input>
            </div>
            <div class="itemGroup2" style="align-self: flex-end;">
                <button type="button" class="btn btn-primary" style="justify-content: center;">新增</button>
            </div>
          </div>
            <div class="srchContext">
                <el-card class="box-card" v-for="(f,index) in filed">
                    <div slot="header" class="clearfix" style="display: flex;height: 38px;">
                          <span>{{filed[index]}}</span>
                          <img src="vue\img\add.png" alt="" style="width:25px; height:25px;cursor: pointer;" @click="drawer2 = true" type="primary">
                    </div>
                    <div class="text-item">
                      <table>
                        <tr style="cursor: move;">
                          <td style="width: 210px; padding: 10px;">一般諮詢</td>
                          <td style="padding:15px 10px;"><img src="vue\img\dustbin.png" alt="" style="width:17px;cursor: pointer;"></td>
                        </tr>
                        <tr style="cursor: move;">
                          <td style="width: 210px;padding: 10px;">一般諮詢</td>
                          <td style="padding: 15px 10px;"><img src="vue\img\dustbin.png" alt="" style="width:17px;cursor: pointer;"></td>
                        </tr>
                      </table>
                      <div class="cardBtn" style="margin-top:20px">
                        <button type="button" class="btn btn-danger">移除</button>
                        
                      </div>
                    </div>
                </el-card>
                <el-drawer  v-model="drawer2" :direction="direction2">
                   <div class="cardBtn" style="margin-bottom: 10px;justify-content: flex-end;display: flex;">
                        <button type="button" class="btn btn-success">確定</button>
                    </div>
                  <table style="margin: 0 20px;">
                    <tr>
                      <td><el-input placeholder="搜尋" prefix-icon="el-icon-search"></el-input></td>
                      <td><el-input placeholder="新增資料夾"></el-input></td>
                    </tr>
                    <tr>
                      <td>TermCode</td>
                      <td></td>
                    </tr>
                    <tr>
                      <td>查詢</td>
                      <td><input type="checkbox" name="" id=""></td>
                    </tr>
                  </table>
                 
                </el-drawer>
            </div>
            <div class="btn">
              <button type="button" class="btn btn-success">儲存</button>
  
            </div>
          </div>
        </div>
      </div>

    </div><!--整個main結束點-->
  </div>
</template>
<script>
export default {
  data() {
    return {
      drawer2: false,
      direction2: 'btt',
      drawer: false,
      DB: ["w08DBRD01", "w08DB001", "G5"],
      tableData: [
        {
          name: "Phone",
          site: "1",
          systype: "3",
          service: "Viantest_RD (1236)",
        },
        {
          name: "CustomerID",
          site: "1",
          systype: "3",
          service: "AgentGreeting (155)",
        },
        {
          name: "CustomerName",
          site: "1",
          systype: "3",
          service: "Brands_A1 (344)",
        },
        {
          name: "Email",
          site: "1",
          systype: "3",
          service: "Ecovacs_AU_RC (772)",
        },
      ],
      filed:['有效','無效',	'其他',	'查詢','接通','未接通','拒絕','回撥'],
      cards:[
        {name:"Phone", checked: true, value:""},
        {name:"CustomerID", checked: true, value:""},
        {name:"CustomerName", checked: true, value:""},
        {name:"Email", checked: true, value:""},
        {name:"MemberID",checked: true, value:""}
      ],

    };
  },
  methods: {
    tableRowClassName({ row, rowIndex }) {
      if (rowIndex === 1) {
        return "warning-row";
      } else if (rowIndex === 3) {
        return "success-row";
      }
      return "";
    },
  },
};
</script>

