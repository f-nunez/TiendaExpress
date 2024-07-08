import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'not-found-page',
  templateUrl: './not-found-page.component.html',
  styleUrl: './not-found-page.component.scss'
})
export class NotFoundPageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Page not found');
  }
}
