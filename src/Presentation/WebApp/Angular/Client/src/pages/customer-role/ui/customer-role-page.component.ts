import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'customer-role-page',
  templateUrl: './customer-role-page.component.html',
  styleUrl: './customer-role-page.component.scss'
})
export class CustomerRolePageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Customer Role');
  }
}
