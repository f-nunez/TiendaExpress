import { Injectable } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { APP_NAME } from '~shared/config';

@Injectable({ providedIn: 'root' })
export class TitleService {

    constructor(private titleService: Title) { }

    getTitle() {
        this.titleService.getTitle();
    }
    setTitle(title: string) {
        if (!title)
            this.titleService.setTitle(APP_NAME);
        else
            this.titleService.setTitle(`${APP_NAME} - ${title}`);
    }
}