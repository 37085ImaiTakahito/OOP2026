namespace SelfOrderSystem.Models;

public static class OrderStatusExtensions {
    // 日本語表示
    public static string ToJapanese(this OrderStatus status) {
        return status switch {
            OrderStatus.New => "新規注文",
            OrderStatus.Accepted => "受付済み",
            OrderStatus.Cooking => "調理中",
            OrderStatus.Served => "提供済み",
            _ => "不明"
        };
    }

    // 次に押すボタンの表示
    public static string NextActionLabel(this OrderStatus status) {
        return status switch {
            OrderStatus.New => "受付する",
            OrderStatus.Accepted => "調理開始",
            OrderStatus.Cooking => "提供完了",
            OrderStatus.Served => "完了",
            _ => string.Empty
        };
    }

    // ステータス表示用CSSクラス
    public static string BadgeClass(this OrderStatus status) {
        return status switch {
            OrderStatus.New => "staff-status-new",
            OrderStatus.Accepted => "staff-status-accepted",
            OrderStatus.Cooking => "staff-status-cooking",
            OrderStatus.Served => "staff-status-served",
            _ => string.Empty
        };
    }

    // 進捗率
    public static int Progress(this OrderStatus status) {
        return status switch {
            OrderStatus.New => 25,
            OrderStatus.Accepted => 50,
            OrderStatus.Cooking => 75,
            OrderStatus.Served => 100,
            _ => 0
        };
    }

    // 次のステータス
    public static OrderStatus? NextStatus(this OrderStatus status) {
        return status switch {
            OrderStatus.New => OrderStatus.Accepted,
            OrderStatus.Accepted => OrderStatus.Cooking,
            OrderStatus.Cooking => OrderStatus.Served,
            _ => null
        };
    }

    // 完了判定
    public static bool IsCompleted(this OrderStatus status) {
        return status == OrderStatus.Served;
    }

    // カード左線用クラス
    public static string CardClass(this OrderStatus status) {
        return status switch {
            OrderStatus.New => "status-new",
            OrderStatus.Accepted => "status-accepted",
            OrderStatus.Cooking => "status-cooking",
            OrderStatus.Served => "status-served",
            _ => string.Empty
        };
    }
}