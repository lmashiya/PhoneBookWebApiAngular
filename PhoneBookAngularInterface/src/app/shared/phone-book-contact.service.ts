import { Injectable } from '@angular/core';
import { PhoneBookContact } from './phone-book-contact.model';

@Injectable({
  providedIn: 'root'
})
export class PhoneBookContactService {
  formData: PhoneBookContact;
  constructor() { }
}
