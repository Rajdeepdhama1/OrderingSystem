import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ItemMaster',
  templateUrl: './ItemMaster.component.html'
})
export class ItemMasterComponent {
  public categories: any;
  public ItemMasterModel = {
    ItemId: 0,
    CategoryName: "",
    ItemName: "",
    CategoryID:"",
  };


  private _http: HttpClient;
    _baseUrl: string;


  constructor(http: HttpClient, @Inject('API_URL') ApiUrl: string) {
    this._baseUrl = ApiUrl;
    http.get(ApiUrl + 'Default/GetCategory').subscribe(result => {
      this.categories = result;
      console.log(this.categories);
      this._http = http;
      this.ItemMasterModel = {
        ItemId: 0,
        CategoryName: "",
        ItemName: "",
        CategoryID: "",
      }
    }, error => console.error(error));
  }
  Save() {
    this._http.post<ItemMasterModel>(this._baseUrl + 'Default/SaveItem', this.ItemMasterModel).subscribe(result => {
      alert("Saved Successfully");
    }, error => console.error(error));
  }
}
interface ItemMasterModel {
  ItemId: number;
  CategoryName: string;
  ItemName: string;
  CategoryID: number;
}
