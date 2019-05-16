import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ItemOrder',
  templateUrl: './ItemOrder.component.html'
})
export class ItemOrderComponent implements OnInit {
 
  public customers: any;
  public arr: Array<{ customerID: number, itemID: number, ItemOrderQuantity: number, TotalAmount: number }> = [];
  public orderedItems: any;
  public customerDataModel = {
    customerID: null,
    customerName: "",
    customerEmail: ""
  };
  itemObj: any;
  public itemMasterModel = {
    itemID: 0,
    itemName: "",
  };
  public ItemOrder = {
    OrderID: 0,
    ItemOrderQuantity: 0,
    TotalAmount: 0,
    customerID: 0,
    itemID: 0,
  };
  public RateListModel = {
    itemRate: 0,
    itemID: 0,
  };

  private _baseUrl: string;
  private _http: HttpClient;
  items: ItemMasterModel;
  myPrice: number;
  RateList: any;
  public result: any;

  constructor(http: HttpClient, @Inject('API_URL') apiUrl: string) {
    this._baseUrl = apiUrl;
    this._http = http;
    this.customerDataModel = {
      customerID: 0,
      customerName: "",
      customerEmail: ""
    }
    this.itemMasterModel = {
      itemID: 0,
      itemName: "",

    }
    this.ItemOrder = {
      OrderID: 0,
      ItemOrderQuantity: 0,
      TotalAmount: 0,
      customerID: 0,
      itemID: 0,
    };
    this.RateListModel = {
    itemRate: 0,
    itemID: 0,
  };

    this._http.get<ItemMasterModel>(this._baseUrl + 'Default/GetItems').subscribe(result => {
      this.items = result;
    }, error => console.error(error));

    this._http.get<CustomerDataModel>(this._baseUrl + 'Default/GetCustomers').subscribe(result => {
      this.customers = result;
    }, error => console.error(error));

  }

  ngOnInit(): void {
    this._http.get<any>(this._baseUrl + 'Default/GetRateList').subscribe(result => {
      this.RateList = result;
      console.log(this.RateList);
    }, error => console.error(error));
  }

  Save() {
    this._http.post<void>(this._baseUrl + 'Default/PostItemOrder', this.arr).subscribe(result => {
      alert("Saved Successfully");
    }, error => console.error(error));
  }
  Delete(RowIndex) {
    if (RowIndex > -1) {
      this.arr.splice(RowIndex, 1);
    }
  }

  Add() {
    this.arr.push({
      customerID: this.ItemOrder.customerID,  
      itemID: this.ItemOrder.itemID,
      ItemOrderQuantity: this.ItemOrder.ItemOrderQuantity,
      TotalAmount: this.ItemOrder.TotalAmount,
    })
  }

  getPrice(itemID) {

    var result = this.RateList[itemID]; 
    this.ItemOrder.TotalAmount = parseFloat((result * this.ItemOrder.ItemOrderQuantity).toFixed(2));
    console.log(this.ItemOrder.TotalAmount);
      
    
    //this._http.get<any>(this._baseUrl + 'Default/GetItemRate?id=' + this.ItemOrder.itemID).subscribe(result => {
    //  this.ItemOrder.TotalAmount = parseFloat((result * this.ItemOrder.ItemOrderQuantity).toFixed(2));
    //  console.log(this.ItemOrder.TotalAmount);
    //}, error => console.error(error));
  }

}

interface CustomerDataModel {
  customerID: number;
  customerName: string;
  customerEmail: string;
}

interface ItemMasterModel {
  ItemID: number;
  ItemName: string;

}

interface ItemOrder {
  OrderID: number;
  ItemOrderQuantity: number;
  TotalAmount: number;
  ItemID: number;
  customerID: number;

}
interface RateListModel {
    length: number;
  itemRate: number;
  itemID: number;
}
