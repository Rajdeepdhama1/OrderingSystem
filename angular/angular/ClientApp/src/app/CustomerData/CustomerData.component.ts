import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-CustomerData',
  templateUrl: './CustomerData.component.html'
})
export class CustomerDataComponent {
  public CustomerDataModel = {
    CustomerName: "",
    CustomerEmail:"",
  };


  private _http: HttpClient;
  _baseUrl: string;


  constructor(http: HttpClient, @Inject('API_URL') ApiUrl: string) {
      this._baseUrl = ApiUrl;
      this._http = http;
      this.CustomerDataModel = {
        CustomerName: "",
        CustomerEmail: "",
      }
    }
  Save() {
    this._http.post<CustomerDataModel>(this._baseUrl + 'Default/SaveCustomerData', this.CustomerDataModel).subscribe(result => {
      alert("Saved Successfully");
    }, error => console.error(error));
  }
}
interface CustomerDataModel {
  CustomerName: string;
  CustomerEmail: string;
}

