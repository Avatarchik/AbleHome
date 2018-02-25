from botocore.vendored import requests
import json

class Duncan(object):

    def __init__(self):
        self.particle_url = "https://api.particle.io/v1/devices/DEVICE_ID_HERE"
        self.particle_headers = {'Content-type': 'application/x-www-form-urlencoded'}
        self.access_token = 'ACCESS_TOKEN_HERE'
        self.light_url = 'https://api.lifx.com/v1/lights'
        self.light_token = 'ACCESS_TOKEN_HERE'
        self.light_headers = {"Authorization": "Bearer {}".format(self.light_token)}

    def _get(self, url, headers):
        resp = requests.get(url, headers=headers)
        return resp

    def _post(self, url, payload, headers):
        resp = requests.post(url, data=payload, headers=headers)
        if resp.status_code is 204:
            pass
        else:
            return resp

    def _put(self, url, payload, headers):
        requests.put(url, data=payload, headers=headers)

    def switch_particle(self, direction):
        if direction.lower() == "right"[:len(direction)]:
            direction = "right"
        elif direction.lower() == "left"[:len(direction)]:
            direction = "left"
        params = {'access_token': self.access_token, 'arg': direction.lower().title()}
        return self._post(self.particle_url + '/setArm', params, self.particle_headers)

    def get_light_data(self):
        return self._get(self.light_url + '/all', headers=self.light_headers)

    def set_light(self, power, color="white", brightness=100):
        # if not a str ("on or off"), treat is like a boolean
        if not isinstance(power, str):
            if power:
                power = "on"
            else:
                power = "off"
        payload = {"power": power.lower(), "color": color, "brightness": brightness}
        url = self.light_url + '/label:Dresser/state'
        self._put(url, payload=json.dumps(payload), headers=self.light_headers)
        
    def toggle_light(self):
        url = self.light_url + '/label:Dresser/toggle'
        return self._post(url, payload=json.dumps({}), headers=self.light_headers)
