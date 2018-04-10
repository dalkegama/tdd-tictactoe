import './Player';

export interface IGameState {
    Board: Player;
    Winner: Player;
    IsDraw: boolean;
}