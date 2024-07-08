import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'manager-role-page',
  templateUrl: './manager-role-page.component.html',
  styleUrl: './manager-role-page.component.scss'
})
export class ManagerRolePageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Manager Role');
  }
}
