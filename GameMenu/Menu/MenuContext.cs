namespace Globals.Menu {
    internal class MenuContext {
        private IState CurrentState { get; set; }

        public MenuContext(IState state) { 
            CurrentState = state;
        }

        public void Execute(string? TODO) {
            if (string.IsNullOrWhiteSpace(TODO))
                return;

            IState? nextState = CurrentState.HandleInput(TODO);
            if(nextState is null)
                return;
            CurrentState = nextState;
            Render();
        }
   
        public void Render() {
            Console.Clear();
            CurrentState.Render();
        }
    }
}
