
export class App {
    configureRouter(config, router){
    config.title = 'TSS Tool';
    config.map([
      { route: '',              moduleId: 'no-selection',   title: 'Select'},
      { route: 'estimate-from-hr/',  moduleId: 'estimateFromHR' }
    ]);

    this.router = router;
  }
}
