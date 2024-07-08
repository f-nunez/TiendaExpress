import { Component } from '@angular/core';
import { TitleService } from '~shared/services/title.service';

@Component({
  selector: 'home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})
export class HomePageComponent {
  constructor(private titleService: TitleService) {
    this.titleService.setTitle('Home');
  }
}
