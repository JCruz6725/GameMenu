namespace Globals.Menu {
    internal interface IState : IMenuState {
        public IState? HandleInput(string input);
    }

    public interface IMenuState {
        public void Render();        
    }
}
