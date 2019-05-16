import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ItemInventory',
  templateUrl: './ItemInventory.component.html'
})
export class ItemInventoryComponent {
  public Items: any;
  public ItemInventoryModel = { 
    ItemInventoryId: 0,
    ItemQuantity: "",
    ItemRate: "",
    ItemID: "",
  };


  private _http: HttpClient;
  _baseUrl: string;


  constructor(http: HttpClient, @Inject('API_URL') ApiUrl: string) {
    this._baseUrl = ApiUrl;
    http.get(ApiUrl + 'Default/GetItems').subscribe(result => {
      this.Items = result;
      console.log(this.Items);
      this._http = http;
      this.ItemInventoryModel = {
        ItemInventoryId: 0,
        ItemQuantity: "",
        ItemRate: "",
        ItemID: "",
      }
    }, error => console.error(error));
  }
  Save() {
    this._http.post<ItemInventoryModel>(this._baseUrl + 'Default/SaveItemInventory', this.ItemInventoryModel).subscribe(result => {
      alert("Saved Successfully");
    }, error => console.error(error));
  }
}
interface ItemInventoryModel {
  ItemInventoryId: number;
  ItemQuantity: number;
  ItemRate: number;
  ItemID: number;
}
