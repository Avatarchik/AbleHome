from duncan import Duncan

jesson = Duncan()

def lambda_handler(event, context):
    if event['led'].lower() == "left":
        jesson.switch_particle("l")
        jesson.toggle_light()
    elif event['led'].lower() == "right":
        jesson.switch_particle("r")
        jesson.toggle_light()
    elif event['led'].lower() == "both":
        jesson.switch_particle("r")
        jesson.switch_particle("l")
        jesson.toggle_light()
    return 'Light activated/deactivated'