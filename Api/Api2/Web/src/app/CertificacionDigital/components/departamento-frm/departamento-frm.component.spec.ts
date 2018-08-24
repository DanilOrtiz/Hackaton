import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartamentoFrmComponent } from './departamento-frm.component';

describe('DepartamentoFrmComponent', () => {
  let component: DepartamentoFrmComponent;
  let fixture: ComponentFixture<DepartamentoFrmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DepartamentoFrmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DepartamentoFrmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
