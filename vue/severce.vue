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
                <el-input placeholder="搜尋" prefix-icon="el-icon-search" v-model="input2"></el-input>
                <el-table :data="tableData" :row-class-name="tableRowClassName">
                  <el-table-column width="90px">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                  </el-table-column>
                  <el-table-column prop="site" label="Site" width="110px"></el-table-column>
                  <el-table-column prop="systype" label="SysType" width="110px"></el-table-column>
                  <el-table-column prop="name" label="服務" width="200px"></el-table-column>
                  
                </el-table>
                <button type="button" class="btn btn-primary" style="width: 63px; float: right; margin-top:20px">確定</button>
                    
          
             
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
      </div>

      <div class="tab-pane fade" id="pills-profile3" role="tabpanel" aria-labelledby="pills-profile-tab3">
        <div class="pills-home2">
          425393
        </div>
      </div>

    </div><!--整個main結束點-->
  </div>
</template>
<script>
export default {
  data() {
    return {
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

