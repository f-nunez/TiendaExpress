import { Directive, Input, OnChanges, SimpleChanges, TemplateRef, ViewContainerRef } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { ERole, User } from './types';
import { sessionLib, sessionModel } from '..';

@Directive({
    selector: '[rbac]'
})
export class RoleBasedAccessControlDirective implements OnChanges {
    private requiredRoles: ERole[] = [];
    private visible: boolean = false;

    @Input() set rbac(roles: ERole[]) {
        this.requiredRoles = roles;
    }

    constructor(
        private readonly store: Store,
        private templateRef: TemplateRef<any>,
        private viewContainer: ViewContainerRef
    ) { }

    ngOnChanges(_changes: SimpleChanges): void {
        this.validateAccess();
    }

    private validateAccess() {
        if (this.visible)
            return;

        let user$: Observable<User | null> = this.store.select(sessionModel.selectors.selectUser);

        user$.subscribe(user => {
            if (user == null) {
                this.deniedAccess();
                return;
            }

            if (this.requiredRoles.length == 0) {
                this.allowAccess();
                return;
            }

            const hasAnyRole = sessionLib.roleHelper.existsAnyRoles(user?.roles, this.requiredRoles);

            if (hasAnyRole)
                this.allowAccess();
            else
                this.deniedAccess();
        });
    }

    private allowAccess() {
        this.viewContainer.clear();
        this.viewContainer.createEmbeddedView(this.templateRef);
        this.visible = true;
    }

    private deniedAccess() {
        this.viewContainer.clear();
        this.visible = false;
    }
}
