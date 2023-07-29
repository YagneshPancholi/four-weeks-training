import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TableServicesService {

  constructor() { }
  getName():string{
    return "Bro what is your Name?"
  }
}
