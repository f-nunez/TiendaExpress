import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'authenticated-example-page',
  templateUrl: './authenticated-example-page.component.html',
  styleUrl: './authenticated-example-page.component.scss'
})
export class AuthenticatedExamplePageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Authenticated');
  }
}
