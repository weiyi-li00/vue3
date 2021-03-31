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
              <button type="button" class="btn btn-primary">新增</button>
            </div>
          </div>
        </div>
        <div class="contentA">
          <el-card style="width: 45%">
            <div class="text item" style="width: 600px">
              <el-table :data="tableData" :row-class-name="tableRowClassName">
                <el-table-column prop="site" label="Site" width="90px"></el-table-column>
                <el-table-column prop="systype" label="SysType" width="90px"></el-table-column>
                <el-table-column prop="name" label="服務" width="150px"></el-table-column>
                <el-table-column label="顯示名稱" width="200px"><input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"></el-table-column>
                <el-table-column label="" width="53px"><img src="vue\img\dustbin (1).png" alt="" style="width: 20px"></el-table-column>
              </el-table>
            </div>
          </el-card>
          <el-card style="width: 45%">
            <div>
             <el-input placeholder="请输入内容" prefix-icon="el-icon-search" v-model="input2"></el-input>
              
            </div>
            <div class="text item" style="width: 600px">
              <el-table :data="tableData" :row-class-name="tableRowClassName">
                <el-table-column width="90px">
                  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                    <label class="form-check-label" for="flexCheckDefault"></label>
                </el-table-column>
                <el-table-column prop="site" label="Site" width="90px"></el-table-column>
                <el-table-column prop="systype" label="SysType" width="90px"></el-table-column>
                <el-table-column prop="name" label="服務" width="150px"></el-table-column>
                
              </el-table>
            </div>
            <div class="btns">
                <button type="button" class="btn btn-primary" style="width: 63px;">確定</button>
                <button type="button" class="btn btn-secondary">返回</button>
            </div>
          </el-card>
        </div>
      </div>

      <div class="tab-pane fade" id="pills-profile3" role="tabpanel" aria-labelledby="pills-profile-tab3">
        <div class="pills-home2">
          <!-- <div class="table">
            <el-table :data="tableData" style="width: 98%; margin: 0 auto" :row-class-name="tableRowClassName">
              <el-table-column label="選取" width="100"><el-button type="success" icon="el-icon-check" circle></el-button></el-table-column>
              <el-table-column label="選取" width="100"><img src="vue\img\move.png" alt="" id="move"></el-table-column>
              <el-table-column prop="name" label="欄位名稱" width="200"></el-table-column>
              <el-table-column label="顯示名稱" width="200"><input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"></el-table-column>
            </el-table>
          </div> -->
          <table id="team">
            <tr>
              <td>#</td>
              <td>MACallBack</td>
              <td>Customer_Search</td>
              <td>Customer_CallLog</td>
              <td>History_CallLog</td>
              <td>MAWorkSheet</td>
              <td>WorkSheet_List</td>
              <td>History_WorkSheet</td>
            </tr>
            <tr>
              <td>1</td>
              <td><span>maValue</span><div><img src="vue\img\dustbin (1).png" alt=""></div></td>
              <td>cuValue</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>2</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cuValue</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>3</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cuValue</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>4</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cu</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>5</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cu</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>6</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cu</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
            <tr>
              <td>7</td>
              <td><div>maValue</div><img src="vue\img\dustbin (1).png" alt=""></td>
              <td>cu</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
              <td>param2</td>
            </tr>
          </table>
        </div>
      </div>

    </div><!--整個main結束點-->
  </div>
</template>
<script>
export default {
  data() {
    return {
      drawer: true,
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

