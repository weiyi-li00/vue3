<template>
    <div class="wrap">

                    <ul class="nav nav-pills mb-3" id="pills-tab3" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="pills-home-tab3" data-bs-toggle="pill" data-bs-target="#pills-home3" type="button" role="tab" aria-controls="pills-home" aria-selected="true">NoBar</button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="pills-profile-tab3" data-bs-toggle="pill" data-bs-target="#pills-profile3" type="button" role="tab" aria-controls="pills-profile" aria-selected="false">TeamCode</button>
                      </li>
                    </ul>
                    <div class="tab-content" id="pills-tabContent3">
                      <div class="tab-pane fade show active" id="pills-home3" role="tabpanel" aria-labelledby="pills-home-tab">
                          <div class="pills-home2">
                          <div class="search">
                                    <div class="itemGroup">
                                      <p>資料庫</p>
                                      <select class="form-select" id="inputGroupSelect01">
                                        <option selected v-for=" (d,index) in DB">
                                          {{DB[index]}}
                                        </option>
                                      </select>
                                    </div>
                                    <div class="itemButton">
                                      <button type="button" class="btn btn-primary">新增</button>
                                    </div>
                          </div>
                          </div>
                          <div class="table">
                             <el-table :data="tableData" style="width: 98%; margin: 0 auto" :row-class-name="tableRowClassName">
                                <el-table-column label="服務" width="100"><el-button type="success" icon="el-icon-check" circle></el-button></el-table-column>
                            
                                <el-table-column prop="name" label="欄位名稱" width="200"></el-table-column>
                                <el-table-column label="顯示名稱" width="200"><input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"></el-table-column>
                             </el-table>
                          </div>
                      </div>
                      <div class="tab-pane fade" id="pills-profile3" role="tabpanel">

                        <div class="pills-home2">
                           <p>狀態</p>
                           <div class="table">
                             <el-table :data="tableData" style="width: 98%; margin: 0 auto" :row-class-name="tableRowClassName">
                                <el-table-column label="選取" width="100"><el-button type="success" icon="el-icon-check" circle></el-button></el-table-column>
                                <el-table-column label="選取" width="100"><img src="vue\img\move.png" alt="" id="move"></el-table-column>
                                <el-table-column prop="name" label="欄位名稱" width="200"></el-table-column>
                                <el-table-column label="顯示名稱" width="200"><input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"></el-table-column>
                             </el-table>
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
      DB:["w08DBRD01","w08DB001","G5"],
      tableData: [{
          name: 'Phone',
          
        }, {
          
          name: 'CustomerID',
         
        }, {
          
          name: 'CustomerName',
         
        }, {
          
          name: 'Email',
         
        }],
    }
  },
    methods: {
         tableRowClassName({row, rowIndex}) {
        if (rowIndex === 1) {
          return 'warning-row';
        } else if (rowIndex === 3) {
          return 'success-row';
        }
        return '';
      }
    },
}
</script>

